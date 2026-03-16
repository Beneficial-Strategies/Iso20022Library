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
[IsoId("_VIm2ktp-Ed-ak6NoX_4Aeg_32079845")]
[DisplayName("Charge")]
public record Charge10
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_VIm2k9p-Ed-ak6NoX_4Aeg_32079871")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType1 Type { get; init; }

    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_VIm2lNp-Ed-ak6NoX_4Aeg_32080157")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public TaxationBasis1? ChargeBasis { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_VIm2ldp-Ed-ak6NoX_4Aeg_32080139")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_VIm2ltp-Ed-ak6NoX_4Aeg_32080122")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_VIm2l9p-Ed-ak6NoX_4Aeg_32080182")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }
}
