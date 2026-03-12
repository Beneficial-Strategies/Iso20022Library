// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details an individual currency including details on which country trades the currency.
/// </summary>
[IsoId("_c7l_wX58EeaUaa1DpZmwUw")]
[DisplayName("Securities Currency Identification")]
public partial record SecuritiesCurrencyIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Details the currency name and ISO 4217 currency code.
    /// </summary>
    [IsoId("_dGAgAX58EeaUaa1DpZmwUw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCodeAndName1 Currency { get; init; } 
    
    /// <summary>
    /// Fractional digit for the currency, that is, the number of decimals to use.
    /// </summary>
    [IsoId("_dGAgA358EeaUaa1DpZmwUw")]
    [DisplayName("Fractional Digit")]
    [IsoXmlTag("FrctnlDgt")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? FractionalDigit { get; init; } 
    
    /// <summary>
    /// Details the country name and ISO 3166 country code.
    /// </summary>
    [IsoId("_dGAgBX58EeaUaa1DpZmwUw")]
    [DisplayName("Country Details")]
    [IsoXmlTag("CtryDtls")]
    public required CountryCodeAndName3 CountryDetails { get; init; } 
    
    /// <summary>
    /// Specifies if a currency is a pre Euro currency or not.
    /// </summary>
    [IsoId("_dGAgB358EeaUaa1DpZmwUw")]
    [DisplayName("Pre Euro")]
    [IsoXmlTag("PreEuro")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator PreEuro { get; init; } 
    
    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_dGAgCX58EeaUaa1DpZmwUw")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public Modification1Code? Modification { get; init; } 
    
    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_dGAgC358EeaUaa1DpZmwUw")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public required Period4Choice_ ValidityPeriod { get; init; } 
    
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_dGAgDX58EeaUaa1DpZmwUw")]
    [DisplayName("Last Updated")]
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastUpdated { get; init; } 
    
    
    #nullable disable
    
}
