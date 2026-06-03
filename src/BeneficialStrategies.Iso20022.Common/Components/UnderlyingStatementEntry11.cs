// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the underlying statement entry to which the investigation message refers.
/// </summary>
[IsoId("40cec56e-b22f-436f-9774-349b1a70a720")]
[DisplayName("Underlying Statement Entry11")]
public record UnderlyingStatementEntry11
{
    [IsoId("849e3cc7-0d45-46fe-b627-5a7325bd821f")]
    [DisplayName("Original Account")]
    [IsoXmlTag("OrgnlAcct")]
    public CashAccount40? OriginalAccount { get; init; }

    [IsoId("8a24db2a-db2b-4fe1-8d1a-f5ded1d5b238")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    [IsoId("a5287a7c-83c2-4568-88d4-4e74e3961f03")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    [IsoId("a8bef864-663e-4766-9286-8d7ee56f16d0")]
    [DisplayName("Original Entry Reference")]
    [IsoXmlTag("OrgnlNtryRef")]
    public IsoMax35Text? OriginalEntryReference { get; init; }

    [IsoId("9b4da188-0553-4e34-9c1c-b097599a0777")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    [IsoId("2b2609f6-0002-49c9-8c72-708317b3410b")]
    [DisplayName("Original Entry Amount")]
    [IsoXmlTag("OrgnlNtryAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalEntryAmount { get; init; }

    [IsoId("cc665a1b-245b-4920-aca1-8640795a8822")]
    [DisplayName("Original Entry Value Date")]
    [IsoXmlTag("OrgnlNtryValDt")]
    public DateAndDateTime2Choice? OriginalEntryValueDate { get; init; }
}
