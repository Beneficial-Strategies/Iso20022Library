# tools/snapshot

`fetch_spec_snapshot.py` writes `snapshot-sync/{date}/spec-snapshot.tsv`, the file the snapshot-sync skills grep for every ISO id, definition, code and member, from the resources of the ISO 20022 MCP server. It replaces the `get_spec_snapshot` tool, which was removed when the server's information tools became resources (Iso20022MasterControl#18).

```bash
python3 tools/snapshot/fetch_spec_snapshot.py --key-file ~/.iso20022/api-key
```

- **Key.** The server's bulk reads need an API key (Enterprise tier or higher). Sign in at `{server}/auth/api-key`, which shows the key once; save it to a file outside every repository (`chmod 600`) and give the script its path with `--key-file` or `ISO20022_API_KEY_FILE`. The script never prints it.
- **Server.** `--url` or `ISO20022_MCP_URL`, the `/mcp` endpoint (default: the staging server).
- **Output.** Rows of the same 16 record types and in the same order as the tool wrote them; members and codes alphabetically within their parent, as before (the resources themselves keep the specification's order). About two minutes, no model involved.
- **Checked** against the file the tool wrote for the 2026-09-04 snapshot: all 230,337 rows byte for byte equal. The one header that differs is `# Section: types`, whose item count the tool reported as 0 and this script reports as 366.
