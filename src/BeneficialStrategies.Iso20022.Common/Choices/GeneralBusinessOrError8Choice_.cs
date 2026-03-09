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
    /// Reports either on the business information or on a business error.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError8Choice.BusinessError))]
    [KnownType(typeof(GeneralBusinessOrError8Choice.GeneralBusiness))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeneralBusinessOrError8Choice.BusinessError),nameof(GeneralBusinessOrError8Choice.BusinessError))]
    [JsonDerivedType(typeof(GeneralBusinessOrError8Choice.GeneralBusiness),nameof(GeneralBusinessOrError8Choice.GeneralBusiness))]
    #endif
    [IsoId("_QrN5MXhdEeidzqjNEfehPg")]
    [DisplayName("General Business Or Error 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneralBusinessOrError8Choice_
    #else
    public abstract partial class GeneralBusinessOrError8Choice_
    #endif
    {
    }
}
