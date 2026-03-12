// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_Rt2m8Np-Ed-ak6NoX_4Aeg_-1889591206")]
[DisplayName("Charge")]
public partial record Charge20
{
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_Rt2m8dp-Ed-ak6NoX_4Aeg_-1889590821")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType12Code Type { get; init; } 
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_Rt2m8tp-Ed-ak6NoX_4Aeg_-1546039460")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_Rt2m89p-Ed-ak6NoX_4Aeg_-1889590838")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_Rt2m9Np-Ed-ak6NoX_4Aeg_-1889590683")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_Rt2m9dp-Ed-ak6NoX_4Aeg_-1546039194")]
    [DisplayName("Extended Charge Basis")]
    [IsoXmlTag("XtndedChrgBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedChargeBasis { get; init; } 
    
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_Rt2m9tp-Ed-ak6NoX_4Aeg_-1889590310")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_Rt2m99p-Ed-ak6NoX_4Aeg_-1889590328")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    
    #nullable disable
    
}
