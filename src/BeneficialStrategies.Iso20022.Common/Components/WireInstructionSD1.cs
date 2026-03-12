// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment wire instruction details.
/// </summary>
[IsoId("_1bkGwTL3EeKU9IrkkToqcw_-370608437")]
[DisplayName("Wire Instruction SD")]
public partial record WireInstructionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1bkGwjL3EeKU9IrkkToqcw_727389595")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Quantity of securities concerned in this wire.
    /// </summary>
    [IsoId("_1bkGwzL3EeKU9IrkkToqcw_934645905")]
    [DisplayName("Wire Quantity")]
    [IsoXmlTag("WireQty")]
    public required FinancialInstrumentQuantity15Choice_ WireQuantity { get; init; } 
    
    /// <summary>
    /// Name of the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bkGxDL3EeKU9IrkkToqcw_-1124460777")]
    [DisplayName("Bank Name")]
    [IsoXmlTag("BkNm")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text BankName { get; init; } 
    
    /// <summary>
    /// Street address of the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bt3wDL3EeKU9IrkkToqcw_-1430130088")]
    [DisplayName("Bank Address")]
    [IsoXmlTag("BkAdr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text BankAddress { get; init; } 
    
    /// <summary>
    /// City of the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bt3wTL3EeKU9IrkkToqcw_127659764")]
    [DisplayName("Bank City")]
    [IsoXmlTag("BkCity")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text BankCity { get; init; } 
    
    /// <summary>
    /// Country of the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bt3wjL3EeKU9IrkkToqcw_-1991616409")]
    [DisplayName("Bank Country")]
    [IsoXmlTag("BkCtry")]
    public required CountryCode BankCountry { get; init; } 
    
    /// <summary>
    /// Responsible person in the recipient back for the wire.
    /// </summary>
    [IsoId("_1bt3wzL3EeKU9IrkkToqcw_937087375")]
    [DisplayName("Bank Attention To")]
    [IsoXmlTag("BkAttnTo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text BankAttentionTo { get; init; } 
    
    /// <summary>
    /// Notes or comments for the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bt3xDL3EeKU9IrkkToqcw_-133613549")]
    [DisplayName("Bank Comments")]
    [IsoXmlTag("BkCmnts")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text BankComments { get; init; } 
    
    /// <summary>
    /// Account type at the recipient bank for the wire.
    /// </summary>
    [IsoId("_1bt3xTL3EeKU9IrkkToqcw_-985451270")]
    [DisplayName("Beneficiary Account")]
    [IsoXmlTag("BnfcryAcct")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text BeneficiaryAccount { get; init; } 
    
    /// <summary>
    /// Account identification at the recipient bank for the wire.
    /// </summary>
    [IsoId("_1b3BsDL3EeKU9IrkkToqcw_-120045798")]
    [DisplayName("Beneficiary Account Identification")]
    [IsoXmlTag("BnfcryAcctId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINMax35Text BeneficiaryAccountIdentification { get; init; } 
    
    /// <summary>
    /// Notes or comments for the beneficiary account at the recipient bank for the wire.
    /// </summary>
    [IsoId("_1b3BsTL3EeKU9IrkkToqcw_128635738")]
    [DisplayName("Beneficiary Account Comments")]
    [IsoXmlTag("BnfcryAcctCmnts")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text BeneficiaryAccountComments { get; init; } 
    
    
    #nullable disable
    
}
