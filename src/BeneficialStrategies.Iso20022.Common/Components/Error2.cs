// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the error.
/// </summary>
[IsoId("_rZTGkYgoEeu8-LhY4KPfWg")]
[DisplayName("Error")]
public record Error2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_pNSucT5FEeyHI64WSlzTlg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public Environment33? Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_rez4sYgoEeu8-LhY4KPfWg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Error or rejection transaction.
    /// </summary>
    [IsoId("_rez4s4goEeu8-LhY4KPfWg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction155 Transaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_rez4tYgoEeu8-LhY4KPfWg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_rez4t4goEeu8-LhY4KPfWg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
