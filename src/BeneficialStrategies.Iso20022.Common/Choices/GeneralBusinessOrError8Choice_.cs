// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on the business information or on a business error.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError8Choice.BusinessError))]
    [KnownType(typeof(GeneralBusinessOrError8Choice.GeneralBusiness))]
    [JsonDerivedType(typeof(GeneralBusinessOrError8Choice.BusinessError),nameof(GeneralBusinessOrError8Choice.BusinessError))]
    [JsonDerivedType(typeof(GeneralBusinessOrError8Choice.GeneralBusiness),nameof(GeneralBusinessOrError8Choice.GeneralBusiness))]
    [IsoId("_QrN5MXhdEeidzqjNEfehPg")]
    [DisplayName("General Business Or Error 8 Choice")]
    public abstract partial record GeneralBusinessOrError8Choice_
    {
    }
}
