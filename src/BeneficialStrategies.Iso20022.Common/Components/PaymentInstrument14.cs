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
/// Payment parties for the transfer of cash from the debtor to the creditor.
/// </summary>
[IsoId("_fsCM4E3zEeiQHa-q1Uephw")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_oUR1EE3zEeiQHa-q1Uephw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_rXUvUE3zEeiQHa-q1Uephw")]
    [DisplayName("Credit Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtTrfDtls")]
    #endif
    [IsoXmlTag("CdtTrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditTransfer9? CreditTransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransfer9? CreditTransferDetails { get; init; } 
    #else
    public CreditTransfer9? CreditTransferDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
