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
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_OJv2AZ-YEee28J7y9KlTWg")]
[DisplayName("Limit Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitStructure2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitStructure2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitStructure2( LimitIdentification1Choice_ reqLimitIdentification,Limit8 reqNewLimitValueSet )
    {
        LimitIdentification = reqLimitIdentification;
        NewLimitValueSet = reqNewLimitValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_OUjX05-YEee28J7y9KlTWg")]
    [DisplayName("Limit Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtId")]
    #endif
    [IsoXmlTag("LmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitIdentification1Choice_ LimitIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LimitIdentification1Choice_ LimitIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitIdentification1Choice_ LimitIdentification { get; init; } 
    #else
    public LimitIdentification1Choice_ LimitIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New limit values.
    /// </summary>
    [IsoId("_OUjX1Z-YEee28J7y9KlTWg")]
    [DisplayName("New Limit Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewLmtValSet")]
    #endif
    [IsoXmlTag("NewLmtValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Limit8 NewLimitValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Limit8 NewLimitValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Limit8 NewLimitValueSet { get; init; } 
    #else
    public Limit8 NewLimitValueSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
