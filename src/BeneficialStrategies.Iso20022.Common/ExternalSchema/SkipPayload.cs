// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.ExternalSchema;

/// <summary>
/// Specifies a data structure that allows to include any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;.
/// The processContents value is &apos;skip&apos; which according to the above specification and to Iso20022: 2013 means that the application will not perform further validation processing.
/// </summary>
public record SkipPayload { }
