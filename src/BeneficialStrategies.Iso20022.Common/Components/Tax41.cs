// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax41.
/// </summary>
[IsoId("_ATvMQXNTEe6Y1uOeeiF_Eg")]
[DisplayName("Tax41")]
public partial record Tax41
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax35Text? Description { get; init; } 

    /// <summary>
    /// Exemption.
    /// </summary>
    [DisplayName("Exemption")]
    [IsoXmlTag("Xmptn")]
    public IsoTrueFalseIndicator? Exemption { get; init; } 

    /// <summary>
    /// Exempt Reason.
    /// </summary>
    [DisplayName("Exempt Reason")]
    [IsoXmlTag("XmptRsn")]
    public IsoMax35Text? ExemptReason { get; init; } 

    /// <summary>
    /// Included In Total.
    /// </summary>
    [DisplayName("Included In Total")]
    [IsoXmlTag("InclInTtl")]
    public IsoTrueFalseIndicator? IncludedInTotal { get; init; } 

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; } 

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AddendumTaxType3Code Type { get; init; } 

    
    #nullable disable
    
}
