// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.ExternalSchema;

/// <summary>
/// Specifies a data structure that allows the inclusion of any valid XML structure, for example, through an XML Schema. The property namespace is set to &apos;any&apos;.
/// The processContents value is &apos;strict&apos; which according to the above specification and to ISO 20022: 2013 means that the application must understand and validate the content.
/// </summary>
public partial record StrictPayload
{
    #nullable enable
    
    
    #nullable disable
    
}
