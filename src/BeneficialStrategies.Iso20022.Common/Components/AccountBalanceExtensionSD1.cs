// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_1ZVSIzL3EeKU9IrkkToqcw_-1110692797")]
[DisplayName("Account Balance Extension SD")]
public partial record AccountBalanceExtensionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ZVSJDL3EeKU9IrkkToqcw_-989980963")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_1ZVSJTL3EeKU9IrkkToqcw_-776435633")]
    [DisplayName("Transaction Position")]
    [IsoXmlTag("TxPos")]
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    
    /// <summary>
    /// Effective date of the transaction. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecEDL3EeKU9IrkkToqcw_-938431092")]
    [DisplayName("As Of Date")]
    [IsoXmlTag("AsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AsOfDate { get; init; } 
    
    /// <summary>
    /// Date of the delivery. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecETL3EeKU9IrkkToqcw_-2009552173")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeliveryDate { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs), securities undelivered (FAILs).
    /// </summary>
    [IsoId("_1ZecEjL3EeKU9IrkkToqcw_-1316888267")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    /// <summary>
    /// Account number at receiver’s side. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecEzL3EeKU9IrkkToqcw_-15407467")]
    [DisplayName("Receiver Account Number")]
    [IsoXmlTag("RcvrAcctNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? ReceiverAccountNumber { get; init; } 
    
    /// <summary>
    /// Account number at deliverer’s side. Applicable to Fail transactions.
    /// </summary>
    [IsoId("_1ZecFDL3EeKU9IrkkToqcw_-1012479820")]
    [DisplayName("Deliverer Account Number")]
    [IsoXmlTag("DlvrrAcctNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? DelivererAccountNumber { get; init; } 
    
    
    #nullable disable
    
}
