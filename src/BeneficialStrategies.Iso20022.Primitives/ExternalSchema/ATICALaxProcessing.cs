// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.ExternalSchema;

/// <summary>
/// Specifies a data structure that allows to include any valid XML Structure (that is through an XML Schema).
/// The property namespace is set to 'any'. The processContents value is 'lax'.
/// </summary>
[IsoId("_VD5BwBNrEfC1ZfCQz0xB3g")]
public record ATICALaxProcessing { }
