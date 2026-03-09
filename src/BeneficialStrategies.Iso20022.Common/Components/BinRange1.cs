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
/// Specifies a set of cards which shares the same functionalities.
/// </summary>
[IsoId("_qe2mAHC8Ee2bmOA3bkVsMg")]
[DisplayName("Bin Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BinRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BinRange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BinRange1( System.String reqLowerBin,System.String reqHigherBin )
    {
        LowerBin = reqLowerBin;
        HigherBin = reqHigherBin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Lower value of BIN in the range.
    /// </summary>
    [IsoId("_6yFj8HC8Ee2bmOA3bkVsMg")]
    [DisplayName("Lower Bin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LwrBin")]
    #endif
    [IsoXmlTag("LwrBin")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText LowerBin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LowerBin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LowerBin { get; init; } 
    #else
    public System.String LowerBin { get; set; } 
    #endif
    
    /// <summary>
    /// Higher value of BIN in the range.
    /// </summary>
    [IsoId("_-Bh7cHC8Ee2bmOA3bkVsMg")]
    [DisplayName("Higher Bin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghrBin")]
    #endif
    [IsoXmlTag("HghrBin")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText HigherBin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HigherBin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HigherBin { get; init; } 
    #else
    public System.String HigherBin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
