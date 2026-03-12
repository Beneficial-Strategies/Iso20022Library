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
[IsoId("_5SM54b5YEeexmbB7KsjCwA")]
[DisplayName("Wire Instruction SD")]
public partial record WireInstructionSD3
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_5iuCIb5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Quantity of securities concerned in this wire.
    /// </summary>
    [IsoId("_5iuCI75YEeexmbB7KsjCwA")]
    [DisplayName("Wire Quantity")]
    [IsoXmlTag("WireQty")]
    public required FinancialInstrumentQuantity15Choice_ WireQuantity { get; init; } 
    
    /// <summary>
    /// Name of the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCK75YEeexmbB7KsjCwA")]
    [DisplayName("Bank Name")]
    [IsoXmlTag("BkNm")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BankName { get; init; } 
    
    /// <summary>
    /// Street address of the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCM75YEeexmbB7KsjCwA")]
    [DisplayName("Bank Address")]
    [IsoXmlTag("BkAdr")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BankAddress { get; init; } 
    
    /// <summary>
    /// City of the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCO75YEeexmbB7KsjCwA")]
    [DisplayName("Bank City")]
    [IsoXmlTag("BkCity")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BankCity { get; init; } 
    
    /// <summary>
    /// Country of the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCQ75YEeexmbB7KsjCwA")]
    [DisplayName("Bank Country")]
    [IsoXmlTag("BkCtry")]
    public required CountryCode BankCountry { get; init; } 
    
    /// <summary>
    /// Responsible person in the recipient back for the wire.
    /// </summary>
    [IsoId("_5iuCS75YEeexmbB7KsjCwA")]
    [DisplayName("Bank Attention To")]
    [IsoXmlTag("BkAttnTo")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BankAttentionTo { get; init; } 
    
    /// <summary>
    /// Notes or comments for the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCU75YEeexmbB7KsjCwA")]
    [DisplayName("Bank Comments")]
    [IsoXmlTag("BkCmnts")]
    [IsoSimpleType(IsoSimpleType.Max60Text)]
    [StringLength(maximumLength: 60 ,MinimumLength = 1)]
    public required IsoMax60Text BankComments { get; init; } 
    
    /// <summary>
    /// Account type at the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCW75YEeexmbB7KsjCwA")]
    [DisplayName("Beneficiary Account")]
    [IsoXmlTag("BnfcryAcct")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BeneficiaryAccount { get; init; } 
    
    /// <summary>
    /// Account identification at the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCY75YEeexmbB7KsjCwA")]
    [DisplayName("Beneficiary Account Identification")]
    [IsoXmlTag("BnfcryAcctId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BeneficiaryAccountIdentification { get; init; } 
    
    /// <summary>
    /// Notes or comments for the beneficiary account at the recipient bank for the wire.
    /// </summary>
    [IsoId("_5iuCa75YEeexmbB7KsjCwA")]
    [DisplayName("Beneficiary Account Comments")]
    [IsoXmlTag("BnfcryAcctCmnts")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text BeneficiaryAccountComments { get; init; } 
    
    
    #nullable disable
    
}
