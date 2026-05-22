document.addEventListener("DOMContentLoaded", function () {

    const faqButtons = document.querySelectorAll(".faq-question");

    faqButtons.forEach(button => {

        button.addEventListener("click", function () {

            const answer = this.nextElementSibling;

            if (answer.style.display === "block") {
                answer.style.display = "none";
            }
            else {
                answer.style.display = "block";
            }
        });
    });
});

function toggleFaq(element) {

    const answer = element.nextElementSibling;
    const arrow = element.querySelector(".arrow");

    if (answer.style.display === "block") {

        answer.style.display = "none";
        arrow.classList.remove("rotate");
    }
    else {

        answer.style.display = "block";
        arrow.classList.add("rotate");
    }
}