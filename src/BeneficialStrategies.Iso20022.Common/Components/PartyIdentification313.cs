// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification313.
/// </summary>
[IsoId("_gKWg0YV5Ee-oeNhl-Tk6YQ")]
[DisplayName("Party Identification313")]
public partial record PartyIdentification313
{
    #nullable enable

    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification7> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Certification Breakdown.
    /// </summary>
    [DisplayName("Certification Breakdown")]
    [IsoXmlTag("CertfctnBrkdwn")]
    public ValueList<IsoMax350Text> CertificationBreakdown { get; init; } = [];

    /// <summary>
    /// Certification Type.
    /// </summary>
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType10Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Domicile Country.
    /// </summary>
    [DisplayName("Domicile Country")]
    [IsoXmlTag("DmclCtry")]
    public CountryCode? DomicileCountry { get; init; } 

    /// <summary>
    /// LEI Identification.
    /// </summary>
    [DisplayName("LEI Identification")]
    [IsoXmlTag("LEIId")]
    public IsoLEIIdentifier? LEIIdentification { get; init; } 

    /// <summary>
    /// Non Domicile Country.
    /// </summary>
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public ValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Owned Securities Quantity.
    /// </summary>
    [DisplayName("Owned Securities Quantity")]
    [IsoXmlTag("OwndSctiesQty")]
    public required FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; init; } 

    /// <summary>
    /// Owner Identification.
    /// </summary>
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public required PartyIdentification229Choice_ OwnerIdentification { get; init; } 

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat57Choice_? WithholdingTaxRate { get; init; } 

    
    #nullable disable
    
}
