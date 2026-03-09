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
/// Specifies the details of the modification to be applied on the securities account reference data.
/// </summary>
[IsoId("_70DO0Tp0Eemk2e6qGBk8IQ")]
[DisplayName("Securities Account Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountModification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccountModification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountModification2( DataModification1Code reqScopeIndication,SecuritiesAccountModification2Choice_ reqRequestedModification )
    {
        ScopeIndication = reqScopeIndication;
        RequestedModification = reqRequestedModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_7-eWITp0Eemk2e6qGBk8IQ")]
    [DisplayName("Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScpIndctn")]
    #endif
    [IsoXmlTag("ScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ScopeIndication { get; init; } 
    #else
    public DataModification1Code ScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which elements to be modified for the securities account reference data.
    /// </summary>
    [IsoId("_7-eWIzp0Eemk2e6qGBk8IQ")]
    [DisplayName("Requested Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdMod")]
    #endif
    [IsoXmlTag("ReqdMod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccountModification2Choice_ RequestedModification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccountModification2Choice_ RequestedModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccountModification2Choice_ RequestedModification { get; init; } 
    #else
    public SecuritiesAccountModification2Choice_ RequestedModification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
