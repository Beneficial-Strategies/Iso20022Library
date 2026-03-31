// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// The Any element without further validation processing.
/// </summary>
[IsoId("_RreBWNp-Ed-ak6NoX_4Aeg_-72452402")]
[DisplayName("Skip Processing")]
public record SkipProcessing { }
