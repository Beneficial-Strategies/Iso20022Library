// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the transaction is pending initiation or has been initiated.
    /// </summary>
    [KnownType(typeof(CollateralStatus2Choice.Code))]
    [KnownType(typeof(CollateralStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralStatus2Choice.Code),nameof(CollateralStatus2Choice.Code))]
    [JsonDerivedType(typeof(CollateralStatus2Choice.Proprietary),nameof(CollateralStatus2Choice.Proprietary))]
    #endif
    [IsoId("_5S5l0MX2EeiSF9q-coWegA")]
    [DisplayName("Collateral Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralStatus2Choice_
    #else
    public abstract partial class CollateralStatus2Choice_
    #endif
    {
    }
}
