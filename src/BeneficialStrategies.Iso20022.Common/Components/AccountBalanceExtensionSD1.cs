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
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_1ZVSIzL3EeKU9IrkkToqcw_-1110692797")]
[DisplayName("Account Balance Extension SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalanceExtensionSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountBalanceExtensionSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountBalanceExtensionSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ZVSJDL3EeKU9IrkkToqcw_-989980963")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_1ZVSJTL3EeKU9IrkkToqcw_-776435633")]
    [DisplayName("Transaction Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxPos")]
    #endif
    [IsoXmlTag("TxPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    #else
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Effective date of the transaction. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecEDL3EeKU9IrkkToqcw_-938431092")]
    [DisplayName("As Of Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsOfDt")]
    #endif
    [IsoXmlTag("AsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AsOfDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AsOfDate { get; init; } 
    #else
    public System.DateOnly? AsOfDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the delivery. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecETL3EeKU9IrkkToqcw_-2009552173")]
    [DisplayName("Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDt")]
    #endif
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DeliveryDate { get; init; } 
    #else
    public System.DateOnly? DeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs), securities undelivered (FAILs).
    /// </summary>
    [IsoId("_1ZecEjL3EeKU9IrkkToqcw_-1316888267")]
    [DisplayName("Contra Participant Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ContraPtcptNb")]
    #endif
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContraParticipantNumber { get; init; } 
    #else
    public System.String? ContraParticipantNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Account number at receiver’s side. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecEzL3EeKU9IrkkToqcw_-15407467")]
    [DisplayName("Receiver Account Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrAcctNb")]
    #endif
    [IsoXmlTag("RcvrAcctNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? ReceiverAccountNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiverAccountNumber { get; init; } 
    #else
    public System.String? ReceiverAccountNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Account number at deliverer’s side. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecFDL3EeKU9IrkkToqcw_-1012479820")]
    [DisplayName("Deliverer Account Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrrAcctNb")]
    #endif
    [IsoXmlTag("DlvrrAcctNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? DelivererAccountNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelivererAccountNumber { get; init; } 
    #else
    public System.String? DelivererAccountNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
