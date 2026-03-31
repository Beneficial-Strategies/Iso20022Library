// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide some or all of the members with information related to the processing of the system.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError5Choice.OperationalError))]
    [KnownType(typeof(GeneralBusinessOrError5Choice.BusinessReport))]
    [JsonDerivedType(
        typeof(GeneralBusinessOrError5Choice.OperationalError),
        nameof(GeneralBusinessOrError5Choice.OperationalError)
    )]
    [JsonDerivedType(
        typeof(GeneralBusinessOrError5Choice.BusinessReport),
        nameof(GeneralBusinessOrError5Choice.BusinessReport)
    )]
    [IsoId("_MHmsgZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Or Error 5 Choice")]
    public abstract record GeneralBusinessOrError5Choice_ { }
}
