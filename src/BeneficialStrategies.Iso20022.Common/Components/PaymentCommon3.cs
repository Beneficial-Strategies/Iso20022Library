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
/// Common details for all payment instruction.
/// </summary>
[IsoId("_mKHMIZlgEeeE1Ya-LgRsuQ")]
[DisplayName("Payment Common")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCommon3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_mSmZw5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFr")]
    #endif
    [IsoXmlTag("PmtFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public System1? PaymentFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System1? PaymentFrom { get; init; } 
    #else
    public System1? PaymentFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_mSsgYZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTo")]
    #endif
    [IsoXmlTag("PmtTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public System1? PaymentTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System1? PaymentTo { get; init; } 
    #else
    public System1? PaymentTo { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a transfer.|.
    /// </summary>
    [IsoId("_mSsgY5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Common Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonSts")]
    #endif
    [IsoXmlTag("CmonSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatus3? CommonStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus3? CommonStatus { get; init; } 
    #else
    public PaymentStatus3? CommonStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_mSsgZZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_mSsgZ5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryDt")]
    #endif
    [IsoXmlTag("NtryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EntryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EntryDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EntryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.|.
    /// </summary>
    [IsoId("_mSsgaZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_mSsga5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    #else
    public PaymentOrigin1Choice_? PaymentMethod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
