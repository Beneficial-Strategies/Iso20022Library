// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance information that provides all remittance address elements, that enables the matching, i.e. reconciliation, of a payment with the items that the transaction in intended to settle.
/// </summary>
[IsoId("_QFjMYdp-Ed-ak6NoX_4Aeg_-1561763068")]
[DisplayName("Remittance Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the remittance information, e.g. a remittance advice, which is sent separately from the payment instruction.
    /// </summary>
    [IsoId("_QFjMYtp-Ed-ak6NoX_4Aeg_-1560839700")]
    [DisplayName("Remittance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtId")]
    #endif
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceIdentification { get; init; } 
    #else
    public System.String? RemittanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_QFjMY9p-Ed-ak6NoX_4Aeg_-1561761112")]
    [DisplayName("Remittance Location Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnMtd")]
    #endif
    [IsoXmlTag("RmtLctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceLocationMethod1Code? RemittanceLocationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceLocationMethod1Code? RemittanceLocationMethod { get; init; } 
    #else
    public RemittanceLocationMethod1Code? RemittanceLocationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_QFjMZNp-Ed-ak6NoX_4Aeg_-1561759732")]
    [DisplayName("Remittance Location Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnElctrncAdr")]
    #endif
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? RemittanceLocationElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceLocationElectronicAddress { get; init; } 
    #else
    public System.String? RemittanceLocationElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_QFjMZdp-Ed-ak6NoX_4Aeg_-1560837547")]
    [DisplayName("Remittance Location Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnPstlAdr")]
    #endif
    [IsoXmlTag("RmtLctnPstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress3? RemittanceLocationPostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress3? RemittanceLocationPostalAddress { get; init; } 
    #else
    public NameAndAddress3? RemittanceLocationPostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
