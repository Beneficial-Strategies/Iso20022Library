// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// Technical extension structure that allows to specify any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;.
/// The content of the extension MUST NOT be validated by the receiver (processContent=lax).
/// </summary>
[IsoId("_YWiyNdp-Ed-ak6NoX_4Aeg_-332034688")]
[DisplayName("Extension Contents")]
public record ExtensionContents1 { }
