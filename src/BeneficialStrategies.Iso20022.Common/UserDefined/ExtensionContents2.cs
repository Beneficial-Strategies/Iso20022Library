// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.UserDefined;

/// <summary>
/// Technical extension structure that allows to specify any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;. 
/// The content of the extension MUST be validated by the receiver (processContent=strict), hence the receiver must have the description (e.g. the XML Schema) of the extension.
/// </summary>
[IsoId("_YWiyM9p-Ed-ak6NoX_4Aeg_1061291860")]
[DisplayName("Extension Contents")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtensionContents2
{
    #nullable enable
    
    
    #nullable disable
    
}
