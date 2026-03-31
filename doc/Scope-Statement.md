---
title : "Scope Statement"
description : "Statement of the scope of work done on this library."
summary : "Statement of the scope of work done on this library."
categories : ["ISO20022"]
---
# Beneficial Strategies Implementation Scope

This document gives you an idea of the scope of implementation of this library.

The library currently contains **3,124 message files** across all 36 business areas. The ISO 20022 repository snapshot dated April 24, 2025 (source: [ISO 20022 AI MCP Server](https://beneficialstrategies.com/product/mcp-server/)) defines **3,121 messages**. The library is at near-complete parity with the spec; the small discrepancies are flagged in the table below.

## ISO 20022 Messages by Business Area

Counts verified against actual files in the repository (March 2026) and the ISO 20022 spec snapshot (April 24, 2025).

| Abbreviation | Business Area | Library | Spec | Notes |
|---|---|---:|---:|---|
| acmt | Account management — opening, maintenance, and related activities. | 148 | 148 | ✓ |
| admi | Generic messages — system event notifications, generic rejections, etc. | 13 | 13 | ✓ |
| auth | Reporting miscellaneous financial information to authorities (regulators, tax, customs, enforcement, etc.). | 170 | 170 | ✓ |
| caaa | Card payment transactions and services between a card acceptor and acquirer, including authorisation, cancellation, and capture. | 269 | 269 | ✓ |
| caad | Card-related administrative services between financial institutions and their agents. | 27 | 27 | ✓ |
| caam | Card terminal management services between an ATM and an acquirer. | 37 | 37 | ✓ |
| cafc | Reporting and advising of card payment transactions, including fee collection and charge-backs. | 6 | 6 | ✓ |
| cafm | File management services in a card payment environment. | 6 | 6 | ✓ |
| cafr | Card payment fraud reporting and disposition services. | 12 | 12 | ✓ |
| cain | Card payment transactions and services between a card acquirer and card issuer. | 76 | 76 | ✓ |
| camt | Cash management — reporting and advising the cash side of financial transactions, including cash movements, balances, exceptions, and investigations. | 372 | 373 | ✓ (spec count inflated by 1 duplicate entry) |
| canm | Network management services in a card payment environment. | 12 | 12 | ✓ |
| casp | Card-related transactions and services between a sale system and a Point of Interaction (POI) system. | 114 | 114 | ✓ |
| casr | Card payment settlement reporting services. | 6 | 6 | ✓ |
| catm | Card terminal management services between a Terminal Management System (TMS) and a POI. | 79 | 79 | ✓ |
| catp | ATM transactions and services between ATM equipment and an ATM acquirer, including cash withdrawals and account management. | 44 | 44 | ✓ |
| colr | Collateral management actions. | 56 | 56 | ✓ |
| fxtr | Foreign exchange contract management — reporting, trades, balances, exceptions, and investigations. | 47 | 47 | ✓ |
| head | Business application header — business information relevant before processing a message. | 5 | 4 | ✓ (extra is head.002/BusinessFileHeaderV01, catalogued under OtherMessages but filed here by ISO ID prefix) |
| nvlp | Envelope messages used to bundle multiple message instances, typically for processing or transport. | 2 | 2 | ✓ |
| pacs | Payments clearing and settlement — clearing and settlement of payment transactions between financial institutions. | 91 | 91 | ✓ |
| pain | Payment initiation — customer-initiated payments to a financial institution and their status. | 110 | 110 | ✓ |
| reda | Reference data — financial instruments, parties, accounts, prices, and other supporting business data. | 79 | 79 | ✓ |
| remt | Remittance — communication between creditors and debtors about remittance details associated with payments. | 9 | 9 | ✓ |
| secl | Securities clearing — post-trading, pre-settlement credit exposure, netting, margining, and borrowing. | 15 | 15 | ✓ |
| seev | Securities events — asset servicing, proxy voting, income, and corporate actions. | 407 | 407 | ✓ |
| semt | Securities management — post-settlement reporting on movements, trades, and balances. | 190 | 190 | ✓ |
| sese | Securities settlement — settlement process for securities and its status/confirmation. | 441 | 441 | ✓ |
| setr | Securities trade — order to buy/sell, execution, affirmation, confirmation, allocation, and notification. | 89 | 89 | ✓ |
| supl | Supplementary data extensions that add new components to existing message definitions. | 71 | 71 | ✓ |
| trck | Payment tracking messages. | 3 | 3 | ✓ |
| trea | Treasury operations (obsolete area, being progressively replaced by fxtr and related domains). | 13 | 13 | ✓ |
| tsin | Trade service requests — applications, instructions, acknowledgements, and advice. | 13 | 13 | ✓ |
| tsmt | Ancillary commercial trade services — checking, matching, reporting, exceptions, and investigations. | 69 | 69 | ✓ |
| tsrv | Trade services instruments — issuance, execution, settlement, reimbursement, financing, and undertaking. | 19 | 19 | ✓ |

## Supporting Architecture Counts

Each message requires supporting structures to fully describe its business content. The table below shows counts from the current ISO 20022 specification (source: MCP server, April 24, 2025).

| Component Type | Current Spec |
|---|---:|
| Internal code sets supplying dropdown values defined by the specification | 3,664 |
| External code sets that may change independently of the specification | 309 |
| Message components used to compose complex content | 13,810 |
| Business components used as building blocks across messages | 785 |
| Simple types used for text, dates, etc., usually constrained | 328 |
| Types relating to external schemas | 7 |
| Types relating to user-defined content | 2 |
| Choice types (polymorphic variants) | 4,136 |
| **Total** | **23,041** |
