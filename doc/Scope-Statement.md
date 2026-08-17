---
title : "Scope Statement"
description : "Statement of the scope of work done on this library."
summary : "Statement of the scope of work done on this library."
categories : ["ISO20022"]
---
# Beneficial Strategies Implementation Scope

This document gives you an idea of the scope of implementation of this library.

The library currently contains **3,311 message files** across all 35 business areas. The ISO 20022 repository snapshot dated May 11, 2026 (source: [ISO 20022 AI MCP Server](https://beneficialstrategies.com/product/mcp-server/)) defines **3,312 messages**. The library is at near-complete parity with the spec; the small discrepancy is flagged in the table below.

## ISO 20022 Messages by Business Area

Counts verified against actual files in the repository (August 2026) and the ISO 20022 spec snapshot (May 11, 2026).

| Abbreviation | Business Area | Library | Spec | Notes |
|---|---|---:|---:|---|
| acmt | Account management — opening, maintenance, and related activities. | 152 | 152 | ✓ |
| admi | Generic messages — system event notifications, generic rejections, etc. | 15 | 15 | ✓ |
| auth | Reporting miscellaneous financial information to authorities (regulators, tax, customs, enforcement, etc.). | 172 | 172 | ✓ |
| caaa | Card payment transactions and services between a card acceptor and acquirer, including authorisation, cancellation, and capture. | 295 | 295 | ✓ |
| caad | Card-related administrative services between financial institutions and their agents. | 27 | 27 | ✓ |
| caam | Card terminal management services between an ATM and an acquirer. | 40 | 40 | ✓ |
| cafc | Reporting and advising of card payment transactions, including fee collection and charge-backs. | 6 | 6 | ✓ |
| cafm | File management services in a card payment environment. | 6 | 6 | ✓ |
| cafr | Card payment fraud reporting and disposition services. | 12 | 12 | ✓ |
| cain | Card payment transactions and services between a card acquirer and card issuer. | 76 | 76 | ✓ |
| camt | Cash management — reporting and advising the cash side of financial transactions, including cash movements, balances, exceptions, and investigations. | 373 | 374 | ✓ (spec count inflated by 1 duplicate entry: `RequestToModifyPaymentV03` appears twice under distinct internal IDs) |
| canm | Network management services in a card payment environment. | 12 | 12 | ✓ |
| casp | Card-related transactions and services between a sale system and a Point of Interaction (POI) system. | 130 | 130 | ✓ |
| casr | Card payment settlement reporting services. | 6 | 6 | ✓ |
| catm | Card terminal management services between a Terminal Management System (TMS) and a POI. | 84 | 84 | ✓ |
| catp | ATM transactions and services between ATM equipment and an ATM acquirer, including cash withdrawals and account management. | 44 | 44 | ✓ |
| colr | Collateral management actions. | 56 | 56 | ✓ |
| fxtr | Foreign exchange contract management — reporting, trades, balances, exceptions, and investigations. | 48 | 48 | ✓ |
| head | Business application header — business information relevant before processing a message. | 5 | 5 | ✓ |
| nvlp | Envelope messages used to bundle multiple message instances, typically for processing or transport. | 3 | 3 | ✓ |
| pacs | Payments clearing and settlement — clearing and settlement of payment transactions between financial institutions. | 98 | 98 | ✓ |
| pain | Payment initiation — customer-initiated payments to a financial institution and their status. | 116 | 116 | ✓ |
| reda | Reference data — financial instruments, parties, accounts, prices, and other supporting business data. | 89 | 89 | ✓ |
| remt | Remittance — communication between creditors and debtors about remittance details associated with payments. | 9 | 9 | ✓ |
| secl | Securities clearing — post-trading, pre-settlement credit exposure, netting, margining, and borrowing. | 23 | 23 | ✓ |
| seev | Securities events — asset servicing, proxy voting, income, and corporate actions. | 432 | 432 | ✓ |
| semt | Securities management — post-settlement reporting on movements, trades, and balances. | 208 | 208 | ✓ |
| sese | Securities settlement — settlement process for securities and its status/confirmation. | 472 | 472 | ✓ |
| setr | Securities trade — order to buy/sell, execution, affirmation, confirmation, allocation, and notification. | 114 | 114 | ✓ |
| supl | Supplementary data extensions that add new components to existing message definitions. | 71 | 71 | ✓ |
| trck | Payment tracking messages. | 3 | 3 | ✓ |
| trea | Treasury operations (obsolete area, being progressively replaced by fxtr and related domains). | 13 | 13 | ✓ |
| tsin | Trade service requests — applications, instructions, acknowledgements, and advice. | 13 | 13 | ✓ |
| tsmt | Ancillary commercial trade services — checking, matching, reporting, exceptions, and investigations. | 69 | 69 | ✓ |
| tsrv | Trade services instruments — issuance, execution, settlement, reimbursement, financing, and undertaking. | 19 | 19 | ✓ |

## Supporting Architecture Counts

Each message requires supporting structures to fully describe its business content. The table below shows counts from the current ISO 20022 specification (source: MCP server, May 11, 2026).

| Component Type | Current Spec |
|---|---:|
| Internal code sets supplying dropdown values defined by the specification | 3,815 |
| External code sets that may change independently of the specification | 327 |
| Message components used to compose complex content | 14,564 |
| Business components used as building blocks across messages | 791 |
| Simple types used for text, dates, etc., usually constrained | 339 |
| Types relating to external schemas | 8 |
| Types relating to user-defined content | 2 |
| Choice types (polymorphic variants) | 4,328 |
| **Total** | **24,174** |
