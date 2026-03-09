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
/// Deposit service provided by the ATM inside the session.
/// </summary>
[IsoId("_4TAcsa4OEeWZgJQOa6iKCQ")]
[DisplayName("ATM Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMService13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMService13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMService13( ATMServiceType6Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the deposit service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_4dlVAa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcRef")]
    #endif
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceReference { get; init; } 
    #else
    public System.String? ServiceReference { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_4dlVA64OEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSvcCd")]
    #endif
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMServiceCode { get; init; } 
    #else
    public System.String? ATMServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_4dlVBa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Host Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstSvcCd")]
    #endif
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HostServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostServiceCode { get; init; } 
    #else
    public System.String? HostServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of deposit service selected by the customer.
    /// </summary>
    [IsoId("_4dlVB64OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMServiceType6Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMServiceType6Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType6Code ServiceType { get; init; } 
    #else
    public ATMServiceType6Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_4dlVCa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Variant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcVarntId")]
    #endif
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceVariantIdentification { get; init; } 
    #else
    public System.String? ServiceVariantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// True if deposit with cash back transaction.
    /// </summary>
    [IsoId("_4dlVC64OEeWZgJQOa6iKCQ")]
    [DisplayName("Cash Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBck")]
    #endif
    [IsoXmlTag("CshBck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CashBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashBack { get; init; } 
    #else
    public System.String? CashBack { get; set; } 
    #endif
    
    /// <summary>
    /// True if the deposit transaction is split in multiple accounts.
    /// </summary>
    [IsoId("_4dlVDa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Multi Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MultiAcct")]
    #endif
    [IsoXmlTag("MultiAcct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MultiAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultiAccount { get; init; } 
    #else
    public System.String? MultiAccount { get; set; } 
    #endif
    
    /// <summary>
    /// True if this is not the final deposit.
    /// </summary>
    [IsoId("_BovdAK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Partial Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlDpst")]
    #endif
    [IsoXmlTag("PrtlDpst")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PartialDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialDeposit { get; init; } 
    #else
    public System.String? PartialDeposit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
