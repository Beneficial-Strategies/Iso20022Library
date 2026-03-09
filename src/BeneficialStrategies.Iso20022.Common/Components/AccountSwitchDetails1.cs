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
/// Details of the account switch, including its status and any response codes.
/// </summary>
[IsoId("_8m2xcQ2ZEeSNWNtJlXOAhg")]
[DisplayName("Account Switch Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountSwitchDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchDetails1( System.String reqUniqueReferenceNumber,System.String reqRoutingUniqueReferenceNumber,SwitchType1Code reqSwitchType )
    {
        UniqueReferenceNumber = reqUniqueReferenceNumber;
        RoutingUniqueReferenceNumber = reqRoutingUniqueReferenceNumber;
        SwitchType = reqSwitchType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique number that provides unique and unambiguous identification of the account switch. 
    /// </summary>
    [IsoId("_vm6TwA2aEeSNWNtJlXOAhg")]
    [DisplayName("Unique Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqRefNb")]
    #endif
    [IsoXmlTag("UnqRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text UniqueReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UniqueReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UniqueReferenceNumber { get; init; } 
    #else
    public System.String UniqueReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number that provides unique and unambiguous identification of the account switch. 
    /// Usage: Where one or more account switches have taken place since the original account switch this field contains the unique number that relates to the switch that transferred the account to the latest new account servicer.
    /// </summary>
    [IsoId("_cbscEA2aEeSNWNtJlXOAhg")]
    [DisplayName("Routing Unique Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtgUnqRefNb")]
    #endif
    [IsoXmlTag("RtgUnqRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RoutingUniqueReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RoutingUniqueReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RoutingUniqueReferenceNumber { get; init; } 
    #else
    public System.String RoutingUniqueReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time that the request was received by the central switch service, populated by the central switch service only.
    /// </summary>
    [IsoId("_f7vbYA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Received Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchRcvdDtTm")]
    #endif
    [IsoXmlTag("SwtchRcvdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SwitchReceivedDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SwitchReceivedDateTime { get; init; } 
    #else
    public System.DateTime? SwitchReceivedDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the account switch is expected to have completed. The value is the same as the targeted switch date if the switch completes in the expected timeline.
    /// </summary>
    [IsoId("_o9RtUA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchDt")]
    #endif
    [IsoXmlTag("SwtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SwitchDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SwitchDate { get; init; } 
    #else
    public System.DateOnly? SwitchDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account switch is a full switch or a partial switch.
    /// Usage: A full switch indicates the transfer of the full balance of the account and associated payment mandates. A partial switch indicates the transfer of certain payment mandates to a new account.
    /// </summary>
    [IsoId("_jB57EA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchTp")]
    #endif
    [IsoXmlTag("SwtchTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SwitchType1Code SwitchType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SwitchType1Code SwitchType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SwitchType1Code SwitchType { get; init; } 
    #else
    public SwitchType1Code SwitchType { get; set; } 
    #endif
    
    /// <summary>
    /// State of the account switch at the time the message is sent.
    /// </summary>
    [IsoId("_mPEaoA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchSts")]
    #endif
    [IsoXmlTag("SwtchSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SwitchStatus1Code? SwitchStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SwitchStatus1Code? SwitchStatus { get; init; } 
    #else
    public SwitchStatus1Code? SwitchStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the processing window in which the balance transfer will be processed on the day of the account switch.
    /// </summary>
    [IsoId("_s39aMA2aEeSNWNtJlXOAhg")]
    [DisplayName("Balance Transfer Window")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfWndw")]
    #endif
    [IsoXmlTag("BalTrfWndw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransferWindow1Code? BalanceTransferWindow { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransferWindow1Code? BalanceTransferWindow { get; init; } 
    #else
    public BalanceTransferWindow1Code? BalanceTransferWindow { get; set; } 
    #endif
    
    /// <summary>
    /// Response code and additional information.
    /// </summary>
    [IsoId("_wTtyIBE7EeafpqhYGpTDnw")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseDetails1? Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseDetails1? Response { get; init; } 
    #else
    public ResponseDetails1? Response { get; set; } 
    #endif
    
    
    #nullable disable
    
}
