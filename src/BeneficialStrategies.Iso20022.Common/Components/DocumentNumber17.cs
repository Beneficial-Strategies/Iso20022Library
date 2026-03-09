// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
[IsoId("_LSk44ffZEeiNZp_PtLohLw")]
[DisplayName("Document Number")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentNumber17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentNumber17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentNumber17( DocumentNumber6Choice_ reqNumber )
    {
        Number = reqNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_LSk45_fZEeiNZp_PtLohLw")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentNumber6Choice_ Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentNumber6Choice_ Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber6Choice_ Number { get; init; } 
    #else
    public DocumentNumber6Choice_ Number { get; set; } 
    #endif
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_LSk47_fZEeiNZp_PtLohLw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    public ValueList<Identification27> References { get; init; } = new ValueList<Identification27>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _LSk47_fZEeiNZp_PtLohLw
    
    
    #nullable disable
    
}
