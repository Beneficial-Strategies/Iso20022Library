// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ax9Et9p-Ed-ak6NoX_4Aeg_1251381702")]
[Description(@"Specified the type of modification to be applied on a data set.")]
[Derivations(typeof(DataModification1Code),typeof(DataModification2Code))]
public enum DataModificationCode
{
    /// <summary>
    /// Insert a new set of data.
    /// Encoded/decoded by serializers as &quot;INSE&quot;.
    /// </summary>
    [EnumMember(Value = "INSE")]
    [IsoId("_ax9EuNp-Ed-ak6NoX_4Aeg_1708524214")]
    [Description(@"Insert a new set of data.")]
    InsertNewDataSet,
    
    /// <summary>
    /// Update the details of an existing set of data.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_ayG1sNp-Ed-ak6NoX_4Aeg_1821193248")]
    [Description(@"Update the details of an existing set of data.")]
    UpdateDataSetDetails,
    
    /// <summary>
    /// Delete an existing set of data.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ayG1sdp-Ed-ak6NoX_4Aeg_2075163954")]
    [Description(@"Delete an existing set of data.")]
    DeleteDataSet,
    
}
