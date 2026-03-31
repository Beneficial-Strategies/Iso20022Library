// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_xdKb0WpBEeS4VPLpYyQgxQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment43
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_xqbbwWpBEeS4VPLpYyQgxQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer4 Acquirer { get; init; }

    /// <summary>
    /// Indicates if the acquirer is available to perform payment transactions.
    /// </summary>
    [IsoId("_xqbbw2pBEeS4VPLpYyQgxQ")]
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_xqbbxWpBEeS4VPLpYyQgxQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_xqbbx2pBEeS4VPLpYyQgxQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }
}
