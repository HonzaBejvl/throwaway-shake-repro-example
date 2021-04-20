﻿// <auto-generated/>
#nullable enable

namespace Logic.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.2.0.0")]
    public partial class GetPointsResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::Logic.Graphql.Generated.GetPointsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetPointsResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Logic.Graphql.Generated.IGetPointsResult);
        public GetPointsResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetPointsResultInfo info)
            {
                return new GetPointsResult(MapNonNullableIGetPoints_PointsNonNullableArray(info.Points, snapshot));
            }

            throw new global::System.ArgumentException("GetPointsResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.IGetPoints_Points> MapNonNullableIGetPoints_PointsNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::Logic.Graphql.Generated.State.IPointData>? list, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var points = new global::System.Collections.Generic.List<global::Logic.Graphql.Generated.IGetPoints_Points>();
            foreach (global::Logic.Graphql.Generated.State.IPointData child in list)
            {
                points.Add(MapNonNullableIGetPoints_Points(child, snapshot));
            }

            return points;
        }

        private global::Logic.Graphql.Generated.IGetPoints_Points MapNonNullableIGetPoints_Points(global::Logic.Graphql.Generated.State.IPointData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetPoints_Points? returnValue;
            if (data is global::Logic.Graphql.Generated.State.PointBlurredData pointBlurred)
            {
                returnValue = new global::Logic.Graphql.Generated.GetPoints_Points_PointBlurred(MapNonNullableIGetPoints_Points_Gps(pointBlurred.Gps, snapshot));
            }
            else if (data is global::Logic.Graphql.Generated.State.PointProjectData pointProject)
            {
                if (pointProject.Count.HasValue)
                {
                    throw new global::System.ArgumentNullException();
                }

                returnValue = new global::Logic.Graphql.Generated.GetPoints_Points_PointProject(pointProject.Count!.Value, pointProject.ListingId ?? throw new global::System.ArgumentNullException(), MapNonNullableIGetPoints_Points_Gps(pointProject.Gps, snapshot));
            }
            else if (data is global::Logic.Graphql.Generated.State.PointSimpleData pointSimple)
            {
                returnValue = new global::Logic.Graphql.Generated.GetPoints_Points_PointSimple(pointSimple.ListingId ?? throw new global::System.ArgumentNullException(), MapNonNullableIGetPoints_Points_Gps(pointSimple.Gps, snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        private global::Logic.Graphql.Generated.IGetPoints_Points_Gps MapNonNullableIGetPoints_Points_Gps(global::Logic.Graphql.Generated.State.GpsData data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetPoints_Points_Gps returnValue = default !;
            if (data.__typename.Equals("Gps", global::System.StringComparison.Ordinal))
            {
                returnValue = new GetPoints_Points_Gps_Gps(data.Lat ?? throw new global::System.ArgumentNullException(), data.Lng ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }
}