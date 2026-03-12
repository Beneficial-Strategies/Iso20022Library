// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[IsoId("_BvC_IQ3sEeKIIIcS0K4sAQ")]
[DisplayName("Financial Instrument Details")]
public partial record FinancialInstrumentDetails13
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_CFQftQ3sEeKIIIcS0K4sAQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_CFQfvw3sEeKIIIcS0K4sAQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation6? PriceDetails { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_CFQfyQ3sEeKIIIcS0K4sAQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_CFQf0w3sEeKIIIcS0K4sAQ")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance1? OpeningBalance { get; init; } 
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_CFQf3Q3sEeKIIIcS0K4sAQ")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance1? ClosingBalance { get; init; } 
    
    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_CFQf5w3sEeKIIIcS0K4sAQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction29> Transaction { get; init; } = new ValueList<Transaction29>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CFQf5w3sEeKIIIcS0K4sAQ
    
    
    #nullable disable
    
}
