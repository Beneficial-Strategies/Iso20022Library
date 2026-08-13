# Multiplicity Audit — August 2026 (comprehensive, supersedes March 2026)

**Date:** 2026-08-13
**Method:** Full comparison of every `MSGELEMENT` (`minOccurs`/`maxOccurs`) in the ISO 20022 spec
against the actual C# property type in every `Components/*.cs` file — not a sample. Spec data
pulled via the ISO 20022 MCP server's `get_spec_snapshot('components')` tool (8 paginated calls,
14,564 components / 110,033 elements total) and cached locally at
`docs/multiplicity-defect1-2026-08.tsv` / `docs/multiplicity-defect2-2026-08.tsv` /
`docs/missing-fields-2026-08.tsv` for reproducibility. Audit script: see git history for
`audit.py` (not checked in — was scratchpad tooling; the TSV outputs are the durable record).

**Status:** Defect 1 fixed in full this session. Defect 2 scoped precisely; fix deferred pending
an architecture decision (see below) — this is a much larger undertaking than previously known.

## Why this audit superseded the March one

The March 2026 audit sampled only 28 of ~12,653 components and found an 18/28 (~64%) hit rate for
Defect 1, explicitly flagging itself as non-representative. Extrapolated naively, that rate would
suggest thousands of defects — but the comprehensive count came back at just **80**. Small samples
of a defect that isn't uniformly distributed across the codebase (it clusters in components with
genuinely repeatable/multi-valued spec elements) produce unreliable extrapolations in either
direction. The comprehensive pass is the trustworthy number.

## Defect 1 — `maxOccurs > 1` modeled as a scalar — FIXED (this session)

**80 confirmed instances**, spanning 53 component files. Each was `T? Prop { get; init; }` (or, in
5 cases, `required T Prop { get; init; }`) where the spec's `maxOccurs` was `2`–`1000` or `*`.
Fixed to `ValueList<T> Prop { get; init; } = [];` or `SimpleValueList<T> Prop { get; init; } = [];`
(the latter for `T` = a Codeset enum or an `IIsoSimpleValue<T>` struct; the former for `T` = a
Component or Choice type) — matching the pattern already used correctly everywhere else in the
codebase. Full list: `docs/multiplicity-defect1-2026-08.tsv`.

Verified zero remaining instances by re-running the full audit after the fix.
4,462 Common tests + 62 FluentValidation tests pass; full solution builds clean.

## Defect 2 — `minOccurs >= 1` but the collection allows empty — SCOPED, NOT FIXED

**1,073 fields across 993 components** (1,068 before Defect 1's fix; +5 from the 5 `required`→
`ValueList` conversions in Defect 1, which correctly deferred their minimum-enforcement to this
defect class rather than inventing new machinery). Full list: `docs/multiplicity-defect2-2026-08.tsv`.

This is dramatically larger than the March audit's known scope of 3 fields. Cross-checked against
every validator in `BeneficialStrategies.Iso20022.FluentValidation`: **only 3 of the 993 affected
components have any mitigation at all** — the three already documented
(`DistributionRejectionStatus1Validator`, `PEPISATransfer11Validator`,
`RedemptionMultipleOrder2Validator`). **990 components are completely unmitigated.**

A validator-per-component approach clearly does not scale to ~990 new validators. Needs an
architecture decision before any fix work starts — options include:
- A systemic model-level fix: a non-empty-enforcing collection type (e.g. `RequiredValueList<T>`),
  in the same spirit as this session's `IIsoSimpleValue<T>` primitive-type work — illegal states
  unrepresentable, rather than validated after construction.
- Bulk-generate FluentValidation validators for the 990 components (closer to the existing
  pattern, but a lot of near-duplicate validator code, and doesn't stop a caller from constructing
  an empty collection directly against the model).
- Some hybrid.

**Not scoped yet — needs the user's input before starting.**

## Bonus finding — 108 spec elements with no corresponding C# property at all

Found incidentally while building the audit's local↔spec index (108 `MSGELEMENT` rows whose
`xmlTag` had no match among a correctly-matched component's local properties). Spot-verified one:
`CorporateActionSD27.ConditionalPaymentApplicableFlag` (spec `xmlTag` `CondlPmtAplblFlg`) does not
exist anywhere in `Components/CorporateActionSD27.cs`. This is a different defect class —
**completeness** (missing fields), not multiplicity — and has not been investigated further.
Full list: `docs/missing-fields-2026-08.tsv`. Worth a dedicated audit of its own; not started.

## Reproducing this audit

```bash
# 1. Pull the full spec-side component/element dataset (8 pages; each auto-saves to a local
#    tool-results file when it exceeds the in-context size limit — check the harness's tool-result
#    directory for the saved path after each call).
#    Call: get_spec_snapshot(artifactType='components', page=N) for N in 1..8

# 2. Concatenate only the MSGCOMP/MSGELEMENT data rows from all 8 pages, in page order, into one
#    TSV (strip the '#'-prefixed header/footer comment lines from each page first).

# 3. Run a script that:
#    - Parses every Components/*.cs file, extracting (xmlTag -> propName, csharpType, isCollection)
#      per component, by scanning for [IsoXmlTag("...")] followed within a few lines by
#      `public {required}? {Type}{?}  {PropName} { get; init; }`.
#    - For each MSGELEMENT row, looks up (componentName, xmlTag) in that local index.
#    - Flags: maxOccurs > 1 (or '*') but not a collection type => Defect 1.
#             minOccurs >= 1 and IS a collection type => Defect 2 (no local enforcement exists).
#             xmlTag has no local match despite the component matching => missing field.
```
