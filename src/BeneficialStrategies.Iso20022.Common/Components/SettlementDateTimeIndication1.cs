// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the occurred settlement time(s) of the payment transaction.
/// </summary>
[IsoId("_QIYeB9p-Ed-ak6NoX_4Aeg_-498720410")]
[DisplayName("Settlement Date Time Indication")]
public partial record SettlementDateTimeIndication1
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which a payment has been debited at the transaction administrator. In the case of TARGET, the date and time at which the payment has been debited at the central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIhn4Np-Ed-ak6NoX_4Aeg_-425762310")]
    [DisplayName("Debit Date Time")]
    [IsoXmlTag("DbtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DebitDateTime { get; init; } 
    
    /// <summary>
    /// Date and time at which a payment has been credited at the transaction administrator. In the case of TARGET, the date and time at which the payment has been credited at the receiving central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIhn4dp-Ed-ak6NoX_4Aeg_-356497199")]
    [DisplayName("Credit Date Time")]
    [IsoXmlTag("CdtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreditDateTime { get; init; } 
    
    
    #nullable disable
    
}
