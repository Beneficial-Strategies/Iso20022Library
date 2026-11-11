#!/usr/bin/env python3
"""Writes snapshot-sync/{date}/spec-snapshot.tsv from the resources of the ISO 20022 MCP server.

The snapshot-sync skills grep this file for every ISO id, definition, code and member, so it is written in the format the
`get_spec_snapshot` tool used to produce (one record type per row, TAB separated, sections in the same order). The tool is gone: the
server serves the same data as the resources `iso20022://dictionary/{kind}/details`, `iso20022://catalogue/BusinessArea/details`
and `iso20022://element/{id}/external`, which this script pages through, outside any model's context.

  python3 tools/snapshot/fetch_spec_snapshot.py [--out snapshot-sync/DATE/spec-snapshot.tsv] [--url MCP_URL] [--key-file PATH]

Needs an API key (Bulk Operations or higher), kept outside every repository and never printed:
  1. sign in at {server}/auth/api-key (Google), which shows the key once;
  2. save it to a file, for example ~/.iso20022/api-key, and chmod 600 it;
  3. pass the path with --key-file or the environment variable ISO20022_API_KEY_FILE.
The server address comes from --url or ISO20022_MCP_URL (the /mcp endpoint).

The date of the snapshot is the one the server serves (meta.snapshotDate); with no --out the file goes to snapshot-sync/{date}/spec-snapshot.tsv.
Members are written alphabetically by name within their parent, as `get_spec_snapshot` did; the resources themselves keep the
specification's order (the XSD sequence), which this file does not.
"""
import argparse, json, os, re, sys, urllib.error, urllib.request
from collections import defaultdict

DEFAULT_URL = "https://iso20022-mcp-v1.beneficialstrategies.com/mcp"


class Client:
    """A minimal Streamable HTTP MCP client; it reads resources only."""

    def __init__(self, url, key_file):
        self.url, self.session, self._n = url, None, 1
        self.key = open(os.path.expanduser(key_file)).read().strip()
        self._post({"jsonrpc": "2.0", "id": self._id(), "method": "initialize",
                    "params": {"protocolVersion": "2025-06-18", "capabilities": {}, "clientInfo": {"name": "fetch_spec_snapshot", "version": "1"}}})
        self._post({"jsonrpc": "2.0", "method": "notifications/initialized"}, expect=False)

    def _id(self):
        self._n += 1
        return self._n

    def _post(self, body, expect=True):
        headers = {"Content-Type": "application/json", "Accept": "application/json, text/event-stream", "Authorization": "ApiKey " + self.key}
        if self.session: headers["Mcp-Session-Id"] = self.session
        req = urllib.request.Request(self.url, json.dumps(body).encode(), headers, method="POST")
        try:
            with urllib.request.urlopen(req, timeout=180) as r:
                self.session = r.headers.get("Mcp-Session-Id", self.session)
                text, ctype = r.read().decode(), r.headers.get("Content-Type", "")
        except urllib.error.HTTPError as e:
            raise RuntimeError(f"HTTP {e.code} from the server: {e.read().decode()[:300]}") from None
        if not expect or not text.strip(): return None
        if "text/event-stream" in ctype:
            text = [l[5:].strip() for l in text.splitlines() if l.startswith("data:")][-1]
        msg = json.loads(text)
        if "error" in msg: raise RuntimeError(json.dumps(msg["error"])[:300])
        return msg["result"]

    def read(self, uri):
        for attempt in range(3):
            try:
                result = self._post({"jsonrpc": "2.0", "id": self._id(), "method": "resources/read", "params": {"uri": uri}})
                return json.loads("".join(c.get("text", "") for c in result["contents"]))
            except RuntimeError:
                if attempt == 2: raise

    def pages(self, uri):
        """The children (or values) of every page of a paged resource, following page.nextUri."""
        next_uri = uri + ("&" if "?" in uri else "?") + "take=2000"
        while next_uri:
            r = self.read(next_uri)
            yield from r["data"].get("children", r["data"].get("values", []))
            next_uri = r["page"].get("nextUri")


# --- the text of a field -------------------------------------------------------------------------------------------------------
def text(s):
    """A definition on one line: line breaks become '|', tabs become spaces (what get_spec_snapshot did)."""
    return (s or "").replace("&#xA;", "|").replace("\r\n", "|").replace("\n", "|").replace("\r", "|").replace("\t", " ").rstrip("|")


def status(e): return (e.get("registrationStatus") or "—").replace(" ", "")
def removal(e): return (e.get("attributes") or {}).get("removalDate", "—")[:10]
def ref(e, *relations): return next((r["name"] for r in e.get("references", []) if r["relation"] in relations), "")
def occurs(e): return str(e.get("minOccurs", "")), str(e.get("maxOccurs", "*"))
def by_name(items): return sorted(items, key=lambda x: x.get("name", ""))


def build(client):
    """Returns (date, sections), sections being a list of (name, total, rows)."""
    toc = client.read("iso20022://dictionary")
    date = toc["meta"]["snapshotDate"]
    kinds = {k["xsiType"]: k for k in toc["data"]["kinds"]}
    simple = ["Indicator", "IdentifierSet", "Rate", "Text", "Quantity", "SchemaType", "Binary", "Date", "DateTime", "Month", "Year", "Time", "YearMonth"]

    def entries(kind): return by_name(client.pages(f"iso20022://dictionary/{kind}/details?includeDefinition=true"))

    # messages: the catalogue's business areas hold them; the checksum of a message is in the children listing of its area
    messages, checksum = [], {}
    for a in client.pages("iso20022://catalogue/BusinessArea/children"):
        for m in client.pages(f"iso20022://element/{a['id']}/children"):
            if m.get("xmlElementName") == "messageDefinition": checksum[m["id"]] = m.get("checksum", "")
    for a in client.pages("iso20022://catalogue/BusinessArea/details?includeDefinition=true"):
        for m in a.get("children", []):
            if m.get("xmlElementName") == "messageDefinition": messages.append((a["code"], m))
    messages = sorted(messages, key=lambda x: x[1]["name"])
    rows = []
    for area, m in messages:
        rows.append(["MSGDEF", m["name"], m["id"], area, status(m), removal(m), checksum.get(m["id"], ""), text(m.get("definition"))])
        for b in by_name(c for c in m.get("children", []) if c.get("xmlElementName") == "messageBuildingBlock"):
            rows.append(["MSGBLOCK", m["name"], b["id"], b["name"], b.get("xmlTag", ""), ref(b, "complexType", "simpleType", "type"), *occurs(b), status(b), text(b.get("definition"))])
    sections = [("messages", len(messages), rows)]

    def top(rt, e): return [rt, e["name"], e["id"], status(e), removal(e), e.get("checksum", ""), text(e.get("definition"))]

    rows = []
    for e in entries("MessageComponent"):
        rows.append(top("MSGCOMP", e))
        for m in by_name(c for c in e.get("children", []) if c.get("xmlElementName") == "messageElement"):
            rows.append(["MSGELEMENT", e["name"], m["id"], m["name"], m.get("xmlTag", ""), ref(m, "type", "simpleType", "complexType"), *occurs(m), status(m), text(m.get("definition"))])
    sections.append(("components", kinds["MessageComponent"]["count"], rows))

    rows = []
    for e in entries("ChoiceComponent"):
        rows.append(top("CHOICE", e))
        for m in by_name(c for c in e.get("children", []) if c.get("xmlElementName") == "messageElement"):
            rows.append(["VARIANT", e["name"], m["id"], m["name"], m.get("xmlTag", ""), ref(m, "type", "simpleType", "complexType"), status(m), text(m.get("definition"))])
    sections.append(("choices", kinds["ChoiceComponent"]["count"], rows))

    rows = []
    for e in entries("CodeSet"):
        rows.append(top("CODESET", e))
        for c in sorted((c for c in e.get("children", []) if c.get("xmlElementName") == "code"), key=lambda c: c.get("codeName", "")):
            rows.append(["CODE", e["name"], c["id"], c.get("codeName", ""), status(c), removal(c), text(c.get("definition"))])
        if e.get("isExternal") or e.get("hasExternalList"):
            for v in sorted(client.pages(f"iso20022://element/{e['id']}/external"), key=lambda v: v["codeName"]):
                rows.append(["EXTCODE", e["name"], v["codeName"]])
    sections.append(("codesets", kinds["CodeSet"]["count"], rows))

    rows = []
    for e in entries("BusinessComponent"):
        rows.append(["BIZCOMP", e["name"], e["id"], status(e), e.get("checksum", "")])
        for xsi, rt in (("BusinessAttribute", "BIZATTR"), ("BusinessAssociationEnd", "BIZASSOC")):   # attributes first, then associations
            for m in by_name(c for c in e.get("children", []) if c.get("xsiType") == xsi):
                rows.append([rt, e["name"], m.get("name", ""), ref(m, "simpleType", "complexType", "type"), *occurs(m), status(m)])
    sections.append(("business", kinds["BusinessComponent"]["count"], rows))

    rows = []
    for kind in simple:
        for e in entries(kind): rows.append(top("SIMPLETYPE", e))
    for kind, rt in (("Amount", "AMOUNT"), ("ExternalSchema", "EXTSCHEMA"), ("UserDefined", "USERDEF")):
        for e in entries(kind): rows.append(top(rt, e))
    rows.sort(key=lambda r: ({"SIMPLETYPE": 0, "AMOUNT": 1, "EXTSCHEMA": 2, "USERDEF": 3}[r[0]], r[1]))
    sections.append(("types", sum(kinds[k]["count"] for k in simple) + sum(kinds[k]["count"] for k in ("Amount", "ExternalSchema", "UserDefined")), rows))
    return date, sections


def write(path, sections):
    os.makedirs(os.path.dirname(os.path.abspath(path)), exist_ok=True)
    with open(path, "w", encoding="utf-8", newline="\n") as f:
        for name, total, rows in sections:
            f.write(f"# ISO 20022 Spec Snapshot — {name}\n# Format: TSV — RecordType TAB fields...\n# status values: Registered | ProvisionallyRegistered | Obsolete | —\n")
            for r in rows: f.write("\t".join(r) + "\n")
            f.write(f"# Section: {name} | Page 1 of 1 | Total items in section: {total}\n")


def main():
    p = argparse.ArgumentParser(description=__doc__.split("\n\n")[0])
    p.add_argument("--out"); p.add_argument("--url", default=os.environ.get("ISO20022_MCP_URL", DEFAULT_URL))
    p.add_argument("--key-file", default=os.environ.get("ISO20022_API_KEY_FILE"))
    a = p.parse_args()
    if not a.key_file: sys.exit("No API key file: pass --key-file or set ISO20022_API_KEY_FILE (see the top of this script).")
    client = Client(a.url, a.key_file)
    date, sections = build(client)
    out = a.out or os.path.join("snapshot-sync", date, "spec-snapshot.tsv")
    write(out, sections)
    print(f"snapshot {date}: " + ", ".join(f"{n} {len(r)} rows" for n, _, r in sections) + f" -> {out}")


if __name__ == "__main__":
    main()
