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
    /// Specifies a service level restricted to the proprietary element.
    /// </summary>
    [KnownType(typeof(RestrictedProprietaryChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RestrictedProprietaryChoice.Proprietary),nameof(RestrictedProprietaryChoice.Proprietary))]
    #endif
    [IsoId("_QJa_z9p-Ed-ak6NoX_4Aeg_1495589549")]
    [DisplayName("Restricted Proprietary Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RestrictedProprietaryChoice_
    #else
    public abstract partial class RestrictedProprietaryChoice_
    #endif
    {
    }
}
