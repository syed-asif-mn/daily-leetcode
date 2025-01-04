/**
 * @param {number[]} grades
 * @return {number}
 */
var maximumGroups = function(grades) {

    grades.sort((a, b) => a - b);
    let totalStudents = grades.length;
    let groupCount = 0;
    let currentSize = 1;

    while (totalStudents >= currentSize) {
        totalStudents -= currentSize;
        groupCount++;
        currentSize++;
    }

    return groupCount;
};
