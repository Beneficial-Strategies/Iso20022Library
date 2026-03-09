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
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbmU4dp-Ed-ak6NoX_4Aeg_-1212009635")]
[DisplayName("Cheque")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of cheque to be issued by the first agent.
    /// </summary>
    [IsoId("_QbmU4tp-Ed-ak6NoX_4Aeg_-1211088283")]
    [DisplayName("Cheque Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqTp")]
    #endif
    [IsoXmlTag("ChqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChequeType2Code? ChequeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChequeType2Code? ChequeType { get; init; } 
    #else
    public ChequeType2Code? ChequeType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the cheque number.
    /// </summary>
    [IsoId("_QbmU49p-Ed-ak6NoX_4Aeg_-1211088128")]
    [DisplayName("Cheque Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqNb")]
    #endif
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ChequeNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChequeNumber { get; init; } 
    #else
    public System.String? ChequeNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    [IsoId("_QbmU5Np-Ed-ak6NoX_4Aeg_-1210162253")]
    [DisplayName("Cheque From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqFr")]
    #endif
    [IsoXmlTag("ChqFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress3? ChequeFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress3? ChequeFrom { get; init; } 
    #else
    public NameAndAddress3? ChequeFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_QbmU5dp-Ed-ak6NoX_4Aeg_302562708")]
    [DisplayName("Delivery Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryMtd")]
    #endif
    [IsoXmlTag("DlvryMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; } 
    #else
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party to whom the debtor&apos;s agent should send the cheque.
    /// </summary>
    [IsoId("_QbmU5tp-Ed-ak6NoX_4Aeg_-1210162582")]
    [DisplayName("Deliver To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrTo")]
    #endif
    [IsoXmlTag("DlvrTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress3? DeliverTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress3? DeliverTo { get; init; } 
    #else
    public NameAndAddress3? DeliverTo { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_QbmU59p-Ed-ak6NoX_4Aeg_-1210165061")]
    [DisplayName("Instruction Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrty")]
    #endif
    [IsoXmlTag("InstrPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority2Code? InstructionPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code? InstructionPriority { get; init; } 
    #else
    public Priority2Code? InstructionPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the draft becomes payable and the debtor&apos;s account is debited.
    /// </summary>
    [IsoId("_QbmU6Np-Ed-ak6NoX_4Aeg_-1210164546")]
    [DisplayName("Cheque Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqMtrtyDt")]
    #endif
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ChequeMaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ChequeMaturityDate { get; init; } 
    #else
    public System.DateOnly? ChequeMaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Code agreed between the initiating party and the debtor&apos;s agent, that specifies the cheque layout, company logo and digitised signature to be used to print the cheque.
    /// </summary>
    [IsoId("_QbmU6dp-Ed-ak6NoX_4Aeg_-1210163728")]
    [DisplayName("Forms Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmsCd")]
    #endif
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FormsCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FormsCode { get; init; } 
    #else
    public System.String? FormsCode { get; set; } 
    #endif
    
    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    [IsoId("_QbwF4Np-Ed-ak6NoX_4Aeg_-1210163572")]
    [DisplayName("Memo Field")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MemoFld")]
    #endif
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MemoField { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MemoField { get; init; } 
    #else
    public System.String? MemoField { get; set; } 
    #endif
    
    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_QbwF4dp-Ed-ak6NoX_4Aeg_-1210162797")]
    [DisplayName("Regional Clearing Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgnlClrZone")]
    #endif
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RegionalClearingZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegionalClearingZone { get; init; } 
    #else
    public System.String? RegionalClearingZone { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    [IsoId("_QbwF4tp-Ed-ak6NoX_4Aeg_-196138042")]
    [DisplayName("Print Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtLctn")]
    #endif
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PrintLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrintLocation { get; init; } 
    #else
    public System.String? PrintLocation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
