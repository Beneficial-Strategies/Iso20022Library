// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// The W3C XML Schema that specifies following standard signature:
///  XML Signature Syntax and Processing (Second Edition) W3C Recommendation 10 June 2008
/// http://www.w3.org/TR/2008/REC-xmldsig-core-20080610/.
/// </summary>
[IsoId("_YWZBMNp-Ed-ak6NoX_4Aeg_492078843")]
[DisplayName("XML Signature")]
public record XMLSignature { }
