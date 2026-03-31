// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_RuAX_dp-Ed-ak6NoX_4Aeg_791233590")]
[DisplayName("Charge")]
public record Charge18
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RuAX_tp-Ed-ak6NoX_4Aeg_1336111953")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType11Code Type { get; init; }

    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RuKI8Np-Ed-ak6NoX_4Aeg_1336111970")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; }

    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_RuKI8dp-Ed-ak6NoX_4Aeg_1706442574")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public TaxationBasis2Code? ChargeBasis { get; init; }

    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_RuKI8tp-Ed-ak6NoX_4Aeg_1706442609")]
    [DisplayName("Extended Charge Basis")]
    [IsoXmlTag("XtndedChrgBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedChargeBasis { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RuKI89p-Ed-ak6NoX_4Aeg_791233650")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RuKI9Np-Ed-ak6NoX_4Aeg_791233633")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_RuKI9dp-Ed-ak6NoX_4Aeg_791233685")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }
}
