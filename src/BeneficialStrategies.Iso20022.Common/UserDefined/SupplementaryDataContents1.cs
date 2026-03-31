// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// Technical supplementary data structure that allows to specify any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;.
/// The content of the supplementary data MUST NOT be validated by the receiver (processContent=lax).
/// </summary>
[IsoId("_YWZBMdp-Ed-ak6NoX_4Aeg_-375411192")]
[DisplayName("Supplementary Data Contents")]
public record SupplementaryDataContents1 { }
