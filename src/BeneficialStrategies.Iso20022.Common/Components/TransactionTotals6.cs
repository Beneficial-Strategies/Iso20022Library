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
/// Additional count which may be utilised for reconciliation.
/// </summary>
[IsoId("_uP6W4Xu_EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sum number of all authorisation transactions.
    /// </summary>
    [IsoId("_A8MP0HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Authorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Authorisation { get; init; } 
    #else
    public System.UInt64? Authorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all reversed authorisation transactions.
    /// </summary>
    [IsoId("_EzJ6UHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Authorisation Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRvsl")]
    #endif
    [IsoXmlTag("AuthstnRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AuthorisationReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AuthorisationReversal { get; init; } 
    #else
    public System.UInt64? AuthorisationReversal { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all inquiry transactions.
    /// </summary>
    [IsoId("_HZdOMHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Inquiry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nqry")]
    #endif
    [IsoXmlTag("Nqry")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Inquiry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Inquiry { get; init; } 
    #else
    public System.UInt64? Inquiry { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all reversed inquiry transactions.
    /// </summary>
    [IsoId("_KRVaQHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Inquiry Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NqryRvsl")]
    #endif
    [IsoXmlTag("NqryRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InquiryReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InquiryReversal { get; init; } 
    #else
    public System.UInt64? InquiryReversal { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all financial presentment payment transactions processed.
    /// </summary>
    [IsoId("_NUPxoHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pmts")]
    #endif
    [IsoXmlTag("Pmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Payments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Payments { get; init; } 
    #else
    public System.UInt64? Payments { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all financial presentment payment transactions which have been reversed.
    /// </summary>
    [IsoId("_SAEAgHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Payment Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRvsl")]
    #endif
    [IsoXmlTag("PmtRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PaymentReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PaymentReversal { get; init; } 
    #else
    public System.UInt64? PaymentReversal { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all financial presentment transactions processed.
    /// </summary>
    [IsoId("_WV0f0HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trf")]
    #endif
    [IsoXmlTag("Trf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Transfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Transfer { get; init; } 
    #else
    public System.UInt64? Transfer { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all reversal transactions processed.
    /// </summary>
    [IsoId("_aB3TwHvAEeSLmfFG0DG7zQ")]
    [DisplayName("Transfer Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRvsl")]
    #endif
    [IsoXmlTag("TrfRvsl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TransferReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransferReversal { get; init; } 
    #else
    public System.UInt64? TransferReversal { get; set; } 
    #endif
    
    /// <summary>
    /// Sum number of all fee collection transactions.
    /// </summary>
    [IsoId("_dOp_4HvAEeSLmfFG0DG7zQ")]
    [DisplayName("Fee Collection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeColltn")]
    #endif
    [IsoXmlTag("FeeColltn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? FeeCollection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? FeeCollection { get; init; } 
    #else
    public System.UInt64? FeeCollection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
