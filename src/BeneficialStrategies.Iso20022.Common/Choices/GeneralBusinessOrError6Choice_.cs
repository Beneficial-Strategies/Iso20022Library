// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on the business information or on a business error.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError6Choice.BusinessError))]
    [KnownType(typeof(GeneralBusinessOrError6Choice.GeneralBusiness))]
    [JsonDerivedType(
        typeof(GeneralBusinessOrError6Choice.BusinessError),
        nameof(GeneralBusinessOrError6Choice.BusinessError)
    )]
    [JsonDerivedType(
        typeof(GeneralBusinessOrError6Choice.GeneralBusiness),
        nameof(GeneralBusinessOrError6Choice.GeneralBusiness)
    )]
    [IsoId("_MYGmp5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Or Error 6 Choice")]
    public abstract record GeneralBusinessOrError6Choice_ { }
}
