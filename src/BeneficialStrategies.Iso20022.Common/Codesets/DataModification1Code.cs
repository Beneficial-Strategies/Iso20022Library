// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ax9EsNp-Ed-ak6NoX_4Aeg_-457133032")]
[Description(@"Specified the type of modification to be applied on a data set.")]
[DerivedFrom(typeof(DataModificationCode))]
public enum DataModification1Code
{
    /// <summary>
    /// Insert a new set of data.
    /// Encoded/decoded by serializers as &quot;INSE&quot;.
    /// </summary>
    [EnumMember(Value = "INSE")]
    [IsoId("_ax9Esdp-Ed-ak6NoX_4Aeg_-1785750283")]
    [Description(@"Insert a new set of data.")]
    InsertNewDataSet = DataModificationCode.InsertNewDataSet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the details of an existing set of data.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_ax9Estp-Ed-ak6NoX_4Aeg_-1785750265")]
    [Description(@"Update the details of an existing set of data.")]
    UpdateDataSetDetails = DataModificationCode.UpdateDataSetDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delete an existing set of data.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ax9Es9p-Ed-ak6NoX_4Aeg_-1785749975")]
    [Description(@"Delete an existing set of data.")]
    DeleteDataSet = DataModificationCode.DeleteDataSet, // same ordinal as derivation source for type conversions
    
}
