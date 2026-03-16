// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Transaction131.
/// </summary>
[IsoId("_7KU50ZFLEe6reqfAp4CunQ")]
[DisplayName("Card Payment Transaction131")]
public partial record CardPaymentTransaction131
{
    #nullable enable

    /// <summary>
    /// Currency Conversion.
    /// </summary>
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion31? CurrencyConversion { get; init; } 

    /// <summary>
    /// POI Identification.
    /// </summary>
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; } 

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
