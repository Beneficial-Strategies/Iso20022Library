// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[IsoId("_2ToMQDQOEe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts60
{
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_CHRZdTQPEe2o-K1dwNg8Gg")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_CHRZdjQPEe2o-K1dwNg8Gg")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public ActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }
}
