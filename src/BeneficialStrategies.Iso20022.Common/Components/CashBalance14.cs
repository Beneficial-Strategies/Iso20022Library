// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Balance14.
/// </summary>
[IsoId("_6TlazzEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Balance14")]
public partial record CashBalance14
{
    #nullable enable

    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public ValueList<BranchAndFinancialInstitutionIdentification8> CounterpartyIdentification { get; init; } = [];

    /// <summary>
    /// Counterparty Type.
    /// </summary>
    [DisplayName("Counterparty Type")]
    [IsoXmlTag("CtrPtyTp")]
    public required BalanceCounterparty1Code CounterpartyType { get; init; } 

    /// <summary>
    /// Processing Date.
    /// </summary>
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeSearch4Choice_? ProcessingDate { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<BalanceType11Choice_> Type { get; init; } = [];

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public ValueList<DateAndDateTimeSearch4Choice_> ValueDate { get; init; } = [];

    
    #nullable disable
    
}
