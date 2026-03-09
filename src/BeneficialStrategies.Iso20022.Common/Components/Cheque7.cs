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
[IsoId("_tcJEcFkyEeGeoaLUQk__nA_-387134073")]
[DisplayName("Cheque")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of cheque to be issued.
    /// </summary>
    [IsoId("_tcJEcVkyEeGeoaLUQk__nA_976404247")]
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
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_tcJEclkyEeGeoaLUQk__nA_-1044651388")]
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
    [IsoId("_tcJEc1kyEeGeoaLUQk__nA_-1205181364")]
    [DisplayName("Cheque From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqFr")]
    #endif
    [IsoXmlTag("ChqFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress10? ChequeFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress10? ChequeFrom { get; init; } 
    #else
    public NameAndAddress10? ChequeFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_tcSOYFkyEeGeoaLUQk__nA_-1812000377")]
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
    /// Party to whom the debtor&apos;s agent needs to send the cheque.
    /// </summary>
    [IsoId("_tcSOYVkyEeGeoaLUQk__nA_-1843971141")]
    [DisplayName("Deliver To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrTo")]
    #endif
    [IsoXmlTag("DlvrTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress10? DeliverTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress10? DeliverTo { get; init; } 
    #else
    public NameAndAddress10? DeliverTo { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_tcSOYlkyEeGeoaLUQk__nA_-2054191839")]
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
    [IsoId("_tcSOY1kyEeGeoaLUQk__nA_-1432691134")]
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
    /// Identifies, in a coded form, the cheque layout, company logo and digitised signature to be used to print the cheque, as agreed between the initiating party and the debtor&apos;s agent.
    /// </summary>
    [IsoId("_tcSOZFkyEeGeoaLUQk__nA_1601985680")]
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
    [IsoId("_tcb_YFkyEeGeoaLUQk__nA_-631615173")]
    [DisplayName("Memo Field")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MemoFld")]
    #endif
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> MemoField { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_tcb_YVkyEeGeoaLUQk__nA_200714969")]
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
    [IsoId("_tcb_YlkyEeGeoaLUQk__nA_-1913299118")]
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
    
    /// <summary>
    /// Signature to be used by the cheque servicer on a specific cheque to be printed.
    /// </summary>
    [IsoId("_tcb_Y1kyEeGeoaLUQk__nA_-667422494")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Signature { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
