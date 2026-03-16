// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Politically exposed person checks.
/// </summary>
[IsoId("_kC2a0KeeEemSUcvu_mDC7w")]
[DisplayName("Politically Exposed Person")]
public record PoliticallyExposedPerson1
{
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.)
    /// </summary>
    [IsoId("_m5DL4qeeEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person Type")]
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    public required PoliticalExposureType2Choice_ PoliticallyExposedPersonType { get; init; }

    /// <summary>
    /// Status of the politically exposed person.
    /// </summary>
    [IsoId("_m5DL46eeEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person Status")]
    [IsoXmlTag("PltclyXpsdPrsnSts")]
    public PoliticallyExposedPersonStatus1Choice_? PoliticallyExposedPersonStatus { get; init; }
}
