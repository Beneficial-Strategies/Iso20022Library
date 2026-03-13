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
[IsoId("_jTnCoW-SEeaxWKxOD2aB-w")]
[DisplayName("Financial Instrument Details")]
public partial record FinancialInstrumentDetails25
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_jsKFgW-SEeaxWKxOD2aB-w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_jsKFhW-SEeaxWKxOD2aB-w")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation13? PriceDetails { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_jsKFiW-SEeaxWKxOD2aB-w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_jsKFjW-SEeaxWKxOD2aB-w")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance3? OpeningBalance { get; init; } 
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_jsKFkW-SEeaxWKxOD2aB-w")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance3? ClosingBalance { get; init; } 
    
    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_jsKFlW-SEeaxWKxOD2aB-w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction52> Transaction { get; init; } = [];
    // ID for the above is _jsKFlW-SEeaxWKxOD2aB-w
    
    
    #nullable disable
    
}
