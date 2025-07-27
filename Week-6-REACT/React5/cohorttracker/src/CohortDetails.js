import styles from './CohortDetails.module.css';
function CohortDetails(props) {
    const status = props.cohort?.currentStatus?.toLowerCase();

    // Define whether the status is 'ongoing'
    const isOngoing = status === 'ongoing';
    return (
        <div className={styles.box}>
            <h3 className={isOngoing ? styles.ongoing : styles.other}>
                {props.cohort.cohortCode} -
                <span>{props.cohort.technology}</span>
            </h3>
            <dl>
                <dt>Started On</dt>
                <dd>{props.cohort.startDate}</dd>
                <dt>Current Status</dt>
                <dd>{props.cohort.currentStatus}</dd>
                <dt>Coach</dt>
                <dd>{props.cohort.coachName}</dd>
                <dt>Trainer</dt>
                <dd>{props.cohort.trainerName}</dd>
            </dl>
        </div>

        
    );
}
export default CohortDetails;