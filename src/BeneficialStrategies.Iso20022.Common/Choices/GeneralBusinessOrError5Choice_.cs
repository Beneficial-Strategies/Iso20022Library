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
    /// It is used to provide some or all of the members with information related to the processing of the system.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError5Choice.OperationalError))]
    [KnownType(typeof(GeneralBusinessOrError5Choice.BusinessReport))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeneralBusinessOrError5Choice.OperationalError),nameof(GeneralBusinessOrError5Choice.OperationalError))]
    [JsonDerivedType(typeof(GeneralBusinessOrError5Choice.BusinessReport),nameof(GeneralBusinessOrError5Choice.BusinessReport))]
    #endif
    [IsoId("_MHmsgZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Or Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneralBusinessOrError5Choice_
    #else
    public abstract partial class GeneralBusinessOrError5Choice_
    #endif
    {
    }
}
