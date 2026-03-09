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
[IsoId("_82tWodBxEeihG9bKfarOOA")]
[DisplayName("Document Number")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentNumber16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentNumber16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentNumber16( DocumentNumber5Choice_ reqNumber )
    {
        Number = reqNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_9JOC9dBxEeihG9bKfarOOA")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentNumber5Choice_ Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentNumber5Choice_ Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber5Choice_ Number { get; init; } 
    #else
    public DocumentNumber5Choice_ Number { get; set; } 
    #endif
    
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_9JOC_dBxEeihG9bKfarOOA")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    public ValueList<Identification26> References { get; init; } = new ValueList<Identification26>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9JOC_dBxEeihG9bKfarOOA
    
    
    #nullable disable
    
}
