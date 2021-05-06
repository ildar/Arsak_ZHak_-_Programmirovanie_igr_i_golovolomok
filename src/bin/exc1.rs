// Exercise 1 (p.13 of the book)

const SAMPLES_NUM: u32 = 5000;
const INTERVALS_NUM: usize = 50;
const B_INIT: f32 = 0.123;

fn random(seed: f32) -> f32 {
    let newval = (seed+3.14159).powf(8.);
    newval - newval.trunc()
}

fn main() {
    let mut b = B_INIT;
    let mut intervals = [0; INTERVALS_NUM];

    for _ in 0..SAMPLES_NUM {
        b = random(b);
        intervals[(b*(INTERVALS_NUM as f32)).trunc() as usize] += 1;
    }
    println!("is it even?");
    for i in 0..INTERVALS_NUM {
        println!("{}", intervals[i as usize]);
    }
}
