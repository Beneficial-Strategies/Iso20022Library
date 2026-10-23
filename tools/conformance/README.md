> **These tools act on `src/Common`, which has left this repository**: the records are now written by a source generator from the interfaces of `iso-20022-messages`, so the model that these tools compare with ISO's data and correct is the interfaces. They are kept here until they are moved to that repository and pointed at it; do not run them against this one.

# Conformance tools

Compare the record model with ISO's own data (#41, #39). Derived files go to `../_work/Iso20022Library/` (`ISO20022_WORK` to change it).

1. `mcp_vs_xsd.py <folder with ISO's XSDs> <repo-structure.json>`: reads the ISO 20022 repository file the MCP serves (`~/.iso20022/snapshots/20260904_ISO20022_2013_eRepository.iso20022`) and compares it with the XSDs: element order, XML tags and occurrences of every message, component and choice. It also writes `repo-structure.json`, the structure of every component, choice and message in the repository's order. (Result of 2026-10-18: 601 messages and 6,400 types compared; 6,395 identical.)
2. `code_vs_repo.py`: compares the records with `repo-structure.json` and lists what differs.
3. `reorder_members.py`: puts the properties of every component and message in the repository's order.

The XSDs are ISO's and are not in the repository (see `CLAUDE.md`, "Validating against ISO's XSDs").
