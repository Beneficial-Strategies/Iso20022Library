// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance information that provides all remittance address elements, that enables the matching, i.e. reconciliation, of a payment with the items that the transaction in intended to settle.
/// </summary>
[IsoId("_QFjMYdp-Ed-ak6NoX_4Aeg_-1561763068")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the remittance information, e.g. a remittance advice, which is sent separately from the payment instruction.
    /// </summary>
    [IsoId("_QFjMYtp-Ed-ak6NoX_4Aeg_-1560839700")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_QFjMY9p-Ed-ak6NoX_4Aeg_-1561761112")]
    [DisplayName("Remittance Location Method")]
    [IsoXmlTag("RmtLctnMtd")]
    public RemittanceLocationMethod1Code? RemittanceLocationMethod { get; init; } 
    
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_QFjMZNp-Ed-ak6NoX_4Aeg_-1561759732")]
    [DisplayName("Remittance Location Electronic Address")]
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? RemittanceLocationElectronicAddress { get; init; } 
    
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_QFjMZdp-Ed-ak6NoX_4Aeg_-1560837547")]
    [DisplayName("Remittance Location Postal Address")]
    [IsoXmlTag("RmtLctnPstlAdr")]
    public NameAndAddress3? RemittanceLocationPostalAddress { get; init; } 
    
    
    #nullable disable
    
}
