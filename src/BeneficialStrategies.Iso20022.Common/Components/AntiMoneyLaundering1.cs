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
/// Information requested against money laundering for a transfer transaction.
/// </summary>
[IsoId("_jG3qgHs-EeSTS7uHCe8FPQ")]
[DisplayName("Anti Money Laundering")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AntiMoneyLaundering1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the sender.
    /// </summary>
    [IsoId("_ynk_UHs-EeSTS7uHCe8FPQ")]
    [DisplayName("Sender Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrNm")]
    #endif
    [IsoXmlTag("SndrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SenderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderName { get; init; } 
    #else
    public System.String? SenderName { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the sender.
    /// </summary>
    [IsoId("_36d1QHs-EeSTS7uHCe8FPQ")]
    [DisplayName("Sender Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrAdr")]
    #endif
    [IsoXmlTag("SndrAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress18? SenderAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress18? SenderAddress { get; init; } 
    #else
    public PostalAddress18? SenderAddress { get; set; } 
    #endif
    
    /// <summary>
    /// National identifier number of the sender.
    /// </summary>
    [IsoId("_JJhs0HtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender National Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrNtlIdr")]
    #endif
    [IsoXmlTag("SndrNtlIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderNationalIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderNationalIdentifier { get; init; } 
    #else
    public System.String? SenderNationalIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the national identifier (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_OnaR0HtAEeSTS7uHCe8FPQ")]
    [DisplayName("National Identifier Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtlIdrCtry")]
    #endif
    [IsoXmlTag("NtlIdrCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? NationalIdentifierCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NationalIdentifierCountry { get; init; } 
    #else
    public System.String? NationalIdentifierCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Passport number of the sender.
    /// </summary>
    [IsoId("_R-MAYHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Passport Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrPsptNb")]
    #endif
    [IsoXmlTag("SndrPsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderPassportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderPassportNumber { get; init; } 
    #else
    public System.String? SenderPassportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Country issuing the passport (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_VDe9YHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Passport Issuing Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PsptIssgCtry")]
    #endif
    [IsoXmlTag("PsptIssgCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? PassportIssuingCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PassportIssuingCountry { get; init; } 
    #else
    public System.String? PassportIssuingCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Tax identifier of the sender.
    /// </summary>
    [IsoId("_bkH_4HtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Tax Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrTaxIdr")]
    #endif
    [IsoXmlTag("SndrTaxIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderTaxIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderTaxIdentifier { get; init; } 
    #else
    public System.String? SenderTaxIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the tax (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_fQduwHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Tax Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCtry")]
    #endif
    [IsoXmlTag("TaxCtry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? TaxCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxCountry { get; init; } 
    #else
    public System.String? TaxCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identifier of the sender.
    /// </summary>
    [IsoId("_nfe-oHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Customer Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrCstmrIdr")]
    #endif
    [IsoXmlTag("SndrCstmrIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderCustomerIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderCustomerIdentifier { get; init; } 
    #else
    public System.String? SenderCustomerIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date and place of birth of the sender.
    /// </summary>
    [IsoId("_s2m0UHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Sender Date And Place Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrDtAndPlcOfBirth")]
    #endif
    [IsoXmlTag("SndrDtAndPlcOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPlaceOfBirth? SenderDateAndPlaceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPlaceOfBirth? SenderDateAndPlaceOfBirth { get; init; } 
    #else
    public DateAndPlaceOfBirth? SenderDateAndPlaceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the receiver.
    /// </summary>
    [IsoId("_xrSrUHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Receiver Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrNm")]
    #endif
    [IsoXmlTag("RcvrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ReceiverName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiverName { get; init; } 
    #else
    public System.String? ReceiverName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique transaction reference number for sender and the receiver.
    /// </summary>
    [IsoId("_4Q5GUHtAEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRef")]
    #endif
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionReference { get; init; } 
    #else
    public System.String? TransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
