// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// Technical extension structure that allows to specify any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;.
/// The content of the extension MUST be validated by the receiver (processContent=strict), hence the receiver must have the description (e.g. the XML Schema) of the extension.
/// </summary>
[IsoId("_YWiyM9p-Ed-ak6NoX_4Aeg_1061291860")]
[DisplayName("Extension Contents")]
public record ExtensionContents2 { }
